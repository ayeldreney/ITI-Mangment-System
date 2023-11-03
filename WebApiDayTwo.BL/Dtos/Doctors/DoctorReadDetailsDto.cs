

namespace WebApiDayTwo.BL.Dtos.Doctors
{
    public class DoctorReadDetailsDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Specialization { get; set; } = string.Empty;
    
        public int PrefomanceRate { get; set; }

        public List<PatientChildDto> Patients { get; set; } = new(); 

    }

    public class PatientChildDto {
    
        public int Id { get; set; }
        public string? Name { get; set; }

        public List<IssueChildDto> Issues { get; set; } = new();        
    }


    public class IssueChildDto {
        public int Id { get; set; }
        public string? Name { get; set; }

    }


    /*
    
       Id:1
       Name:'Ahmed' 
       Specialization:'Bone' 
       PrefomanceRate : 9.9
       PatientChildDto:[
        new patient:{1,'mohamed',new Issue{1,'bone'}}
    ]

     
     */



}
