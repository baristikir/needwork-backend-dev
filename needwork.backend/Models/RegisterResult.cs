//
//  RegisterResult.cs
//  needwork
//
//  Created by Baris Tikir on 25.07.20.
//  Copyright © 2020 Baris Tikir. All rights reserved.
//

using System.Collections.Generic;

namespace needwork.backend.Models
{
    //
    // Result model for registration.
    //

    public class RegisterResult
    {
        public string Id { get; set; }
        public bool Successful { get; set; }
        public IEnumerable<string> Errors { get; set; } 
    }
}