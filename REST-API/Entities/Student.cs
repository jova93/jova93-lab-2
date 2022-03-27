using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace REST_API.Entities;

public class Student
{
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public string? MobileNumber { get; set; }
    public string? AddressInformation { get; set; }
    public string? PersonalNumber { get; set; }
    public int CourseId { get; set; }


    [ForeignKey("CourseId")]
    public virtual Course? Course { get; set; }
}