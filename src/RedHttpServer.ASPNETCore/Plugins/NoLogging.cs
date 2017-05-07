using System;
using RedHttpServerCore.Plugins.Interfaces;

namespace RedHttpServerCore.Plugins
{
    /// <summary>
    ///     Logs nothing at all
    /// </summary>
    public sealed class NoLogging : ILogging
    {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

        public void Log(string category, string message)
        {
        }

        public void Log(string message)
        {
        }

        public void Log(Exception exception)
        {
        }

        public bool IncludeStackTrace { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}