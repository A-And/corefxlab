﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace System.IO.Pipelines.Samples
{
    public enum RequestRejectionReason
    {
        UnrecognizedHTTPVersion,
        InvalidRequestLine,
        InvalidRequestHeader,
        InvalidRequestHeadersNoCRLF,
        MalformedRequestInvalidHeaders,
        InvalidContentLength,
        MultipleContentLengths,
        UnexpectedEndOfRequestContent,
        BadChunkSuffix,
        BadChunkSizeData,
        ChunkedRequestIncomplete,
        InvalidCharactersInHeaderName,
        RequestLineTooLong,
        HeadersExceedMaxTotalSize,
        TooManyHeaders,
        RequestTimeout,
        FinalTransferCodingNotChunked,
        LengthRequired,
        LengthRequiredHttp10
    }
}
