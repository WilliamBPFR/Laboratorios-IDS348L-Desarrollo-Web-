using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab_04
{
    public partial class AppEjercicio2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected async void btnPadron_Click(object sender, EventArgs e)
        {
            if (Request.Cookies["NumVisitas"] == null)
            {
                HttpCookie cookie = new HttpCookie("NumVisitas", "0");
                Response.Cookies.Add(cookie);
            }

            if (int.Parse(Request.Cookies["NumVisitas"].Value.ToString()) <=100)
            {
                using (HttpClient wc = new HttpClient())
                {
                    var json = await wc.GetStringAsync($"https://compulaboratoriomendez.com/lib/?Key=DESARROLLOWEB&MUN_CED={txtPri3.Text}&SEQ_CED={txtLargo.Text}&VER_CED={txtVef.Text}");

                    var js = JsonConvert.SerializeObject(json);
                    var k = json.Replace('[', ' ').Replace(']', ' ');
                    var j = JObject.Parse(k);

                    dynamic data = JObject.Parse(k);
                    txtNombre.Text = data.NOMBRES;
                    txtApellido.Text = data.APELLIDO1;
                    txtTelefono.Text = data.TELEFONO;
                    txtFechaNac.Text = data.FECHA_NAC;
                    DateTime fechanac = DateTime.Parse(txtFechaNac.Text);
                    txtLugNac.Text = data.LUGAR_NAC;
                    txtEdad.Text = (DateTime.Now.Year - fechanac.Year).ToString();
                    DateTime ahora = fechanac;
                    if(fechanac.Date == ahora.Date)
                    {
                        Image1.ImageUrl = "/pastel-de-cumpleanos.png";
                    }
                    Response.Cookies["NumVisitas"].Value = (int.Parse(Request.Cookies["NumVisitas"].Value) + 1).ToString();
                }
            }
            else
            {
                LabelNoAdmitido.Text = "Excedió el número de consultas.";
            }
        }
    }
}