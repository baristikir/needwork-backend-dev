//
//  LoginModel.cs
//  needwork
//
//  Created by Baris Tikir on 25.07.20.
//  Copyright © 2020 Baris Tikir. All rights reserved.
//

using System.ComponentModel.DataAnnotations;

namespace needwork.backend.Models
{
    //
    // Model for login credentials
    //

    public class LoginModel
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }

        //optional
        public bool RememberMe { get; set; }
    }
}
