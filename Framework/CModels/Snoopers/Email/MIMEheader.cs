﻿// Copyright (c) 2017 Jan Pluskal
//
//Licensed under the Apache License, Version 2.0 (the "License");
//you may not use this file except in compliance with the License.
//You may obtain a copy of the License at
//
//    http://www.apache.org/licenses/LICENSE-2.0
//
//Unless required by applicable law or agreed to in writing, software
//distributed under the License is distributed on an "AS IS" BASIS,
//WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//See the License for the specific language governing permissions and
//limitations under the License.

namespace Netfox.Framework.Models.Snoopers.Email
{
    /// <summary> A mim eheader.</summary>
    public class MIMEheader
    {
        public MIMEheader() { }//EF
        /// <summary> Gets or sets the type.</summary>
        /// <value> The type.</value>
        public string Type { get; set; }

        /// <summary> Gets or sets the value.</summary>
        /// <value> The value.</value>
        public string Value { get; set; }
    }
}
