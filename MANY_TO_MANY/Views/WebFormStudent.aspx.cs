using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.EntitySql;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HTTPupt;
using MANY_TO_MANY.Models;

namespace MANY_TO_MANY.Views
{
    public partial class WebFormStudent : System.Web.UI.Page
    {
        PeticionHTTP request = new PeticionHTTP("http://localhost:60265");
        protected void Page_Load(object sender, EventArgs e)
        {
            GetStudents();
        }

        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            // creamos un nuevo usuario
            Student student = new Student
            {
                Name = StudentName.Text,
                LastName = StudentLastName.Text,
                Age = int.Parse(StudentAge.Text)
            };
            String serializedJson = JsonConvertidor.Objeto_Json(student);
            request.PedirComunicacion("api/student/create", MetodoHTTP.POST, TipoContenido.JSON);
            request.enviarDatos(serializedJson);
            String json = request.ObtenerJson();

            GetStudents();
        }

        private void GetStudents() {
            request.PedirComunicacion("api/student/all", MetodoHTTP.GET, TipoContenido.JSON);
            String json = request.ObtenerJson();
            List<StudentDTO> students = JsonConvertidor.Json_ListaObjeto<StudentDTO>(json);
            StudentGrid.DataSource = students;
            StudentGrid.DataBind();

        }
        private void FillStudentGrid() {
            request.PedirComunicacion("api/student/all", MetodoHTTP.GET, TipoContenido.JSON);
            String json = request.ObtenerJson();
            List<StudentDTO> students = JsonConvertidor.Json_ListaObjeto<StudentDTO>(json);
           

        }

        
    }
}