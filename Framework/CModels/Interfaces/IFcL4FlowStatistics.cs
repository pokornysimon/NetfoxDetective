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

using System;

namespace Netfox.Framework.Models.Interfaces
{
    /// <summary> Interface for bt statistics.</summary>
    public interface IFcL4FlowStatistics
    {
        /// <summary> Gets or sets the bytes.</summary>
        /// <value> The bytes.</value>
        UInt32 Bytes { get; set; }

        /// <summary> Gets or sets the Date/Time of the first seen.</summary>
        /// <value> The first seen.</value>
        DateTime FirstSeen { get; set; }

        /// <summary> Gets or sets the Date/Time of the last seen.</summary>
        /// <value> The last seen.</value>
        DateTime LastSeen { get; set; }

        /// <summary> Gets or sets the frames.</summary>
        /// <value> The frames.</value>
        UInt32 Frames { get; set; }

        /// <summary> Gets or sets the malformed frames.</summary>
        /// <value> The malformed frames.</value>
        UInt32 MalformedFrames { get; set; }

        /// <summary>
        ///     True if UpFlow TCP.ACKs.Count == DownFlow TCP.SYN+ACKs.Cout &amp;&amp;
        ///     UpFlow TCP.SYN+ACKs.Count == DownFlow TCP.SYNs.Cout
        ///     Otherwords all handshakes are captured False otherwise.
        /// </summary>
        /// <value> true if TCP handshakes consistant, false if not.</value>
        Boolean TCPHandshakesConsistant { get; set; }

        /// <summary> Gets the identifier of the bidirectional flow.</summary>
        /// <value> The identifier of the bidirectional flow.</value>
        Int64 L4FlowId { get; }
    }
}