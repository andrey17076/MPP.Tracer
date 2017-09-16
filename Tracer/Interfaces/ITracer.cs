﻿using Tracer.Models;

namespace Tracer.Interfaces
{
    public interface ITracer
    {
        void StartTrace();
        void StopTrace();
        TraceResult GetTraceResult();
    }
}