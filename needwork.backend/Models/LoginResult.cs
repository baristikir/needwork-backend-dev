//
//  LoginResult.cs
//  needwork
//
//  Created by Baris Tikir on 25.07.20.
//  Copyright © 2020 Baris Tikir. All rights reserved.
//

namespace needwork.backend.Models
{
    //
    // Model fo login answer. Indicates login success and a token for authentication
    //

    public class LoginResult
    {
        /// <summary>
        /// indicates if the login succeeded
        /// </summary>
        public bool Successful { get; set; }
        /// <summary>
        /// error message
        /// </summary>
        public string Error { get; set; }
        /// <summary>
        /// Token to indentify the user
        /// </summary>
        public string Token { get; set; }
    }
}
