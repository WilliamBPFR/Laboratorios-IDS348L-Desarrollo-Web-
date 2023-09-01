using Amazon;
using Amazon.Rekognition;
using Amazon.Rekognition.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab_04
{
    public partial class AppEjercici1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected async void btnConsultar_Click(object sender, EventArgs e)
        {
            if (fuImagen.HasFile)
            {
                AmazonRekognitionClient rekognitionClient = new AmazonRekognitionClient();
                Amazon.Rekognition.Model.Image image = new Amazon.Rekognition.Model.Image();
                try
                {
                    byte[] fileData = null;
                    using (var binaryReader = new BinaryReader(fuImagen.PostedFile.InputStream))
                    {
                        fileData = binaryReader.ReadBytes(fuImagen.PostedFile.ContentLength);
                    }
                    image.Bytes = new MemoryStream(fileData);
                }
                catch (Exception ex) { }
                DetectTextRequest request = new DetectTextRequest() { Image = image };
                DetectTextResponse response = rekognitionClient.DetectText(request);

                if (response.TextDetections.Count > 0)
                {
                    string texto = "";
                    string cedula = "";
                    foreach (var item in response.TextDetections)
                    {
                        texto = item.DetectedText;
                        string patron = @"\b\d{3}-\d{7}-\d{1}\b"; // Expresión regular para el formato de cédula

                        Match match = Regex.Match(texto, patron);

                        if (match.Success)
                        {
                            cedula = match.Value;

                        }
                        Label1.Text += item.DetectedText;
                    }

                    using(HttpClient wc = new HttpClient())
                    {
                        var json = await wc.GetStringAsync($"https://compulaboratoriomendez.com/lib/?Key=DESARROLLOWEB&MUN_CED={cedula.Substring(0, 3)}&SEQ_CED={cedula.Substring(4, 7)}&VER_CED={cedula[12]}");

                        var js = JsonConvert.SerializeObject(json);
                        var k = json.Replace('[',' ').Replace(']',' ');
                        var j = JObject.Parse(k);

                        dynamic data = JObject.Parse(k);
                        TextBox1.Text = data.NOMBRES + " " + data.APELLIDO1;
                        
                    }
                }
            }
        }
    }
}