// Copyright (c) 2016-2022 James Skimming. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

namespace Castle.DynamicProxy;

using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Reports;
using BenchmarkDotNet.Running;

public static class Program
{
    public static void Main()
    {
        Summary[] summaries = BenchmarkRunner.Run(typeof(Program).Assembly);
        ////Summary summary =
        ////    BenchmarkRunner.Run<IncompleteResultTaskAsynchronousInterceptorBenchmarks>();
    }
}
