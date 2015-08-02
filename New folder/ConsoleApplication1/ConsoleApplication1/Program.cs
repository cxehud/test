using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using Checkmarx.DataTypes;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https://github.com/cxehud/test/";


            ProjectGITSetting settings = new ProjectGITSetting();

            settings.Url = url;

            settings.GitHubSettings = new ProjectGITSetting.ProjectGitHubIntegrationSettings();

            settings.GitHubSettings.Username = "cxehud";
            settings.GitHubSettings.Password = "Zaqxswcde1";

            string se = ProjectGITSetting.SourceRepositorySettings2String(settings);


            Uri uri = new Uri(url);

            string[] segments = uri.AbsolutePath.Split('/').Where(segment => !string.IsNullOrEmpty(segment)).ToArray();

            string s = Console.ReadLine();

            string a = Console.ReadLine();

            string d = s;

            string b = d;
            
            string sql = "select * from v where a = " + b;
            OleDbCommand c = new OleDbCommand(sql);

            OleDbDataAdapter adapter = new OleDbDataAdapter();

            adapter.SelectCommand = c;

            adapter.Fill(new System.Data.DataSet());
        }
    }
}
