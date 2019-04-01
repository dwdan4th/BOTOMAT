using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BOTOMAT
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Robbit> r2 = new List<Robbit>();
            r2.Add(new Robbit("manny",6000));
            r2.Add(new Robbit("jack",2000));
        }

        //[WebMethod]
        //public void DoMe(string name)  //, string desc
        //{
        //    int j = 6;
        //}
    }

    public class Robbit
    {
        string robotname;
        string type = "human";
        int time;

        public Robbit(string name, int dur)
        {
            robotname = name;
            time = dur;
            Thread robotThread = new Thread(new ThreadStart(Runns));
            robotThread.Start();
           // Runns();
        }

        public void Runns()
        {
         
            Thread.Sleep(this.time);
            breaker(this);
        }

        public void breaker(Robbit r)
        {
            string name = r.robotname;
            var z = r;
        }
    }
}