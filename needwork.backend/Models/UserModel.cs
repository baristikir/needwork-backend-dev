//
//  UserModel.cs
//  needwork
//
//  Created by Baris Tikir on 25.07.20.
//  Copyright © 2020 Baris Tikir. All rights reserved.
//

using Microsoft.AspNetCore.Identity;

namespace needwork.backend.Models
{
    public class UserModel : IdentityUser
    {
        public bool isAuthenticated { get; set; }
    }
}
