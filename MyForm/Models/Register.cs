using System;
 using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

public class Register {
   [Required]
    [StringLength(10)]
    public string? FirstName {
        get;
        set;
    }
    [ValidateNever]
    public string? LastName {
        get;
        set;
    }
    
    public int UserId {
        get;
        set;
    }
   
    [Required]
    public string? Password {
        get;
        set;
    }
   

   

    [Compare(nameof(Password),ErrorMessage = "password and confirm password do not match")]
     public string? ConfirmPassword {
        get;
        set;
    }

    [Required]
    [EmailAddress (ErrorMessage ="invalid email")]
    public string? Email {
        get;
        set;
    }
    [Required]
    public string? Contact {
        get;
        set;
    }
}