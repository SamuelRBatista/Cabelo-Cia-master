using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyApp.Models
{
    public class Appointment
    {
        public int AppointmentId { get; set; }

        [Required, MaxLength(80, ErrorMessage = "Nome não poder exceder a 80 caracteres")]
        [DisplayName("Nome")]
        public string AppointmentClient { get; set; }

        [DisplayName("Data e horário")]
        public DateTime AppointmentDateTime { get; set; }

        public int CategoryServiceId { get; set; }

        [DisplayName("Tipo de Serviço")]
        public CategoryService CategoryService { get; set; }
        // Other relevant properties
    }
}
