namespace Second_ASP_EF_MVC.Dtos.DepartmentsDtos
{

    public class CreateDepartmentDto
    {
        public string Name { get; set; }
    }

    public class UpdateDepartmentDto : CreateDepartmentDto
    {
        public int Id { get; set; }

    }

    public class DepartmentDto : UpdateDepartmentDto
    {


    }

}
