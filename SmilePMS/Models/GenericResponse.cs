using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace SmilePMS.Models
{
    public class GenericResponse<T> 
    {
        public GenericResponse()
        {
            Success = true;
            Message = string.Empty;
        }

        #region Response Status code
        /// <summary>
        /// A second, private property to set <see cref="StatusCode"/> by value of other json field name
        /// </summary>
        /// 
        [Required]
        [Display(Name = "success")]
        public bool Success { get; set; }
        #endregion
        [Display(Name = "message")]
        public string Message { get; set; }

        [Display(Name = "data")]
        public T? Data { get; set; }
    }
}
