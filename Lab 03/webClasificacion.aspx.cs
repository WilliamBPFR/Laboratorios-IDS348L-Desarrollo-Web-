using Amazon;
using Amazon.Rekognition;
using Amazon.Rekognition.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab_03
{
    public partial class webClasificacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnVerificar_Click(object sender, EventArgs e)
        {
            if (fuImagen.HasFile)
            {
                fuImagen.SaveAs(MapPath("Apto") + @"\" + fuImagen.FileName);
                fuImagen.SaveAs(MapPath("No Apto") + @"\" + fuImagen.FileName);
                imagen.ImageUrl = "/Apto/" + fuImagen.FileName;
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
                DetectModerationLabelsRequest request = new DetectModerationLabelsRequest() { Image = image };
                DetectModerationLabelsResponse response = rekognitionClient.DetectModerationLabels(request);

                if (response.ModerationLabels.Count>0)
                {
                    File.Delete(MapPath("/Apto/")+fuImagen.FileName);
                    imagen.ImageUrl = "/No Apto/" + fuImagen.FileName;
                    labelModeracion.Text = "La Imagen no es Apta";
                }
                else
                {
                    File.Delete(MapPath("/No Apto/") + fuImagen.FileName);
                    imagen.ImageUrl = "/Apto/" + fuImagen.FileName;
                    labelModeracion.Text = "La Imagen es Apta";
                }
            }
        }
    }
}