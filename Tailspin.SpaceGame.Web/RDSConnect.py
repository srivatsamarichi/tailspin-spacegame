import psycopg2
from ssm_parameter_store import EC2ParameterStore
def main():
    access_id = input("\nProvide AWS access ID: ")
    access_key= input("Provide AWS secret key: ")
    
    #Connect to SSM Parameter store
    print('\nFetching Credentials from SSM Parameter Store...')
    store = EC2ParameterStore(
            aws_access_key_id=access_id,
            aws_secret_access_key=access_key,
            region_name='ap-south-1')
    
    # Fetch the data
    parameters = store.get_parameters(['db_name', 'db_user', 'db_password', 'db_host', 'db_port'])
    db_host = parameters["db_host"]
    db_port = parameters["db_port"]
    db_name = parameters["db_name"]
    db_user = parameters["db_user"]
    db_password = parameters["db_password"]
    
    # connect to the PostgreSQL server
    print('\nConnecting to the PostgreSQL database...\n')
    conn = psycopg2.connect(host=db_host,
                            database=db_name,
                            user=db_user,
                            password=db_password,
                            port=db_port)
                         
    # create a cursor
    cur = conn.cursor()

    # Define the PostgreSQL statement
    s = "SELECT version()"
    
    # execute a statement
    cur.execute(s)
    db_version = cur.fetchone()
    
    # display the output
    print("Connected Successfully....")
    print("RDS Version Spec:",db_version[0],end="\n")
    print("Endpoint:",db_host,sep=" ",end="\n")
    print("Port:",db_port,sep=" ",end="\n")
                       
    # close the communication with the PostgreSQL
    cur.close()

if __name__ == '__main__':
    main()
