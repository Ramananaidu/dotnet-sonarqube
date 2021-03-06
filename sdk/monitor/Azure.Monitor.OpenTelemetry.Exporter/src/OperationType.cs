// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Azure.Monitor.OpenTelemetry.Exporter
{
    internal enum OperationType
    {
        Unknown,
        Azure,
        Common,
        Db,
        FaaS,
        Http,
        Messaging,
        Rpc
    };
}
