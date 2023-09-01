using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Amazon;
using Amazon.Rekognition;
using Amazon.Rekognition.Model;

namespace Lab_03
{
    public partial class webVisa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if (fileUpload.HasFile)
            {
                string name = fileUpload.PostedFile.FileName;
                fileUpload.SaveAs(MapPath("Imagenes Visa") + @"\" + fileUpload.FileName);
                fotoPersona.ImageUrl = "/Imagenes Visa/" + fileUpload.FileName;
                AmazonRekognitionClient rekognitionClient = new AmazonRekognitionClient();
                Amazon.Rekognition.Model.Image image = new Amazon.Rekognition.Model.Image();
                try
                {
                    byte[] fileData = null;
                    using(var binaryReader = new BinaryReader(fileUpload.PostedFile.InputStream))
                    {
                        fileData = binaryReader.ReadBytes(fileUpload.PostedFile.ContentLength);
                    }
                    image.Bytes = new MemoryStream(fileData);
                }
                catch (Exception ex) { }
                DetectFacesRequest request = new DetectFacesRequest() { Image = image};
                DetectFacesResponse response = rekognitionClient.DetectFaces(request);

                if(response.FaceDetails.Count != 1)
                {
                    labelImagenValida.Text = "La Imagen no es válida. No tiene un solo rostro";
                    File.Delete(MapPath("Imagenes Visa") + @"\" + name);
                }
                else
                {
                        System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Chawillfer\\source\\repos\\ProyectoFinalIDS345 - Tienda de Videojuegos\\Proyecto de Web\\Lab 03\\App_Data\\DBLAB03.mdf\";Integrated Security=True");
                        connection.Open();

                        System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand();
                        command.Connection = connection;
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.CommandText = "spVisa";
                         command.Parameters.AddWithValue("@TipoDocumento",txtTipoDox.Text);
                         command.Parameters.AddWithValue("@Nombres", txtNombre.Text);
                         command.Parameters.AddWithValue("@Apellidos", txtApellido.Text);
                         command.Parameters.AddWithValue("@FechaNac", txtFechaNac.SelectedDate);
                         command.Parameters.AddWithValue("@Sexo", txtSexo.Text);
                         command.Parameters.AddWithValue("@Ocupacion", txtOcupacion.Text);
                         command.Parameters.AddWithValue("@Salario", txtSalario.Text);
                         command.Parameters.AddWithValue("@Casapropia", txtCasaPropia.Text);
                         command.Parameters.AddWithValue("@vehiculo",txtVehiculo.Text);
                         command.Parameters.AddWithValue("@estado", txtEstado.Text);
                         command.Parameters.AddWithValue("@lugartrabajo", txtLugarTrabajo.Text);
                         command.Parameters.AddWithValue("@nivelacademico", txtNivelAcademico.Text);
                         command.Parameters.AddWithValue("@foto", "imagen");


                        command.ExecuteNonQuery();
                        labelImagenValida.Text = "Guardado con Exito";
                }
            }
        }
    }
}