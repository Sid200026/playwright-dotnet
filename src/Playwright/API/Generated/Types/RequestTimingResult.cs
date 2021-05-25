/*
 * MIT License
 *
 * Copyright (c) Microsoft Corporation.
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.Playwright
{
    /// <summary>
    /// Result of calling <see cref="IRequest.Timing"/>.
    /// </summary>
    public partial class RequestTimingResult
    {
        /// <summary><para>Request start time in milliseconds elapsed since January 1, 1970 00:00:00 UTC</para></summary>
        [JsonPropertyName("startTime")]
        public float StartTime { get; set; }

        /// <summary>
        /// <para>
        /// Time immediately before the browser starts the domain name lookup for the resource.
        /// The value is given in milliseconds relative to <c>startTime</c>, -1 if not available.
        /// </para>
        /// </summary>
        [JsonPropertyName("domainLookupStart")]
        public float DomainLookupStart { get; set; }

        /// <summary>
        /// <para>
        /// Time immediately after the browser starts the domain name lookup for the resource.
        /// The value is given in milliseconds relative to <c>startTime</c>, -1 if not available.
        /// </para>
        /// </summary>
        [JsonPropertyName("domainLookupEnd")]
        public float DomainLookupEnd { get; set; }

        /// <summary>
        /// <para>
        /// Time immediately before the user agent starts establishing the connection to the
        /// server to retrieve the resource. The value is given in milliseconds relative to
        /// <c>startTime</c>, -1 if not available.
        /// </para>
        /// </summary>
        [JsonPropertyName("connectStart")]
        public float ConnectStart { get; set; }

        /// <summary>
        /// <para>
        /// Time immediately before the browser starts the handshake process to secure the current
        /// connection. The value is given in milliseconds relative to <c>startTime</c>, -1
        /// if not available.
        /// </para>
        /// </summary>
        [JsonPropertyName("secureConnectionStart")]
        public float SecureConnectionStart { get; set; }

        /// <summary>
        /// <para>
        /// Time immediately before the user agent starts establishing the connection to the
        /// server to retrieve the resource. The value is given in milliseconds relative to
        /// <c>startTime</c>, -1 if not available.
        /// </para>
        /// </summary>
        [JsonPropertyName("connectEnd")]
        public float ConnectEnd { get; set; }

        /// <summary>
        /// <para>
        /// Time immediately before the browser starts requesting the resource from the server,
        /// cache, or local resource. The value is given in milliseconds relative to <c>startTime</c>,
        /// -1 if not available.
        /// </para>
        /// </summary>
        [JsonPropertyName("requestStart")]
        public float RequestStart { get; set; }

        /// <summary>
        /// <para>
        /// Time immediately after the browser starts requesting the resource from the server,
        /// cache, or local resource. The value is given in milliseconds relative to <c>startTime</c>,
        /// -1 if not available.
        /// </para>
        /// </summary>
        [JsonPropertyName("responseStart")]
        public float ResponseStart { get; set; }

        /// <summary>
        /// <para>
        /// Time immediately after the browser receives the last byte of the resource or immediately
        /// before the transport connection is closed, whichever comes first. The value is given
        /// in milliseconds relative to <c>startTime</c>, -1 if not available.
        /// </para>
        /// </summary>
        [JsonPropertyName("responseEnd")]
        public float ResponseEnd { get; set; }
    }
}