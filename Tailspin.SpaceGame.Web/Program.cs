using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace TailSpin.SpaceGame.Web
{
    public class Program
    {
        public static string ClientSecret = "eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsIng1dCI6Im9PdmN6NU1fN3AtSGpJS2xGWHo5M3VfVjBabyJ9.eyJjaWQiOiI2MDQ5NzdkYy1mZWFmLTQ5ZGItOWQzNS1mMmFkZjU0MDMxYTYiLCJjc2kiOiIzZTIxODZlOS01ZDAyLTQ5MTMtYjBiMC02ZGJlYmNmZmVlZTQiLCJuYW1laWQiOiI5ZjNlMTMyOS0yNzE3LTYxZWMtOTE1Yy04ODdlZDRjY2YxZjEiLCJpc3MiOiJhcHAudnNzcHMudmlzdWFsc3R1ZGlvLmNvbSIsImF1ZCI6ImFwcC52c3Nwcy52aXN1YWxzdHVkaW8uY29tIiwibmJmIjoxNTIxNTM4MjUyLCJleHAiOjE2NzkzMDQ2NTJ9.1vxe_uSKYVmvKros4VeZN27Py1haA6L8l5yUMtG0fWOrBD3-i2k3s4afJ6Chl_MS6kg210x1XSG5ppaNh8btV8r4r5IGpYxKtrSfMY4QJc0YJ1TEVlXSD5J2wMzFH3XQeswgZXPwVfyYjsPK6_XwyPT6WlwUpe5UxehG34-0gluy4P2J4OcHMvJI0UQn_YPR-b52hEGm02fJF4Wh4NGpLMHf4qJvqVLao0A51nL6XBADvYd5yuuPM8qtqiUxk2_08K8_jAEKhiwUDGT0hEbo0DudiP5bmmXSfiS_LOaHpqMql55y1a-aTo8vaD22nP1GHE42UsHF-hopbejmexfQ5Q";
        public static string Password = "sri@123";
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
