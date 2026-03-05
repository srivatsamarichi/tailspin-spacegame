import psycopg2
from ssm_parameter_store import EC2ParameterStore


def main():
    access_id = input("\nProvide AWS access ID: ")
    access_key = input("Provide AWS secret key: ")

    # Connect to SSM Parameter Store
    print("\nFetching Credentials from SSM Parameter Store...")

    store = EC2ParameterStore(
        aws_access_key_id=access_id,
        aws_secret_access_key=access_key,
        region_name="ap-south-1",
    )

    # Fetch the data
    parameters = store.get_parameters(
        ["db_name", "db_user", "db_password", "db_host", "db_port"]
    )

    db_host = parameters["db_host"]
    db_port = parameters["db_port"]
    db_name = parameters["db_name"]
    db_user = parameters["db_user"]
    db_password = parameters["db_password"]

    # Connect to the PostgreSQL server
    print("\nConnecting to the PostgreSQL database...\n")

    conn = psycopg2.connect(
        host=db_host,
        database=db_name,
        user=db_user,
        password=db_password,
        port=db_port,
    )

    # Create a cursor
    cur = conn.cursor()

    # Define the PostgreSQL statement
    query = "SELECT version()"

    # Execute the statement
    cur.execute(query)
    db_version = cur.fetchone()

    # Display the output
    print("Connected Successfully....")
    print("RDS Version Spec:", db_version[0])
    print("Endpoint:", db_host)
    print("Port:", db_port)

    # Close the communication with PostgreSQL
    cur.close()
    conn.close()


if __name__ == "__main__":
    main()