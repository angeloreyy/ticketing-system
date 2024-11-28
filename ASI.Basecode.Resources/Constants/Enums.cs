﻿namespace ASI.Basecode.Resources.Constants
{
    /// <summary>
    /// Class for enumerated values
    /// </summary>
    public class Enums
    {
        /// <summary>
        /// API Result Status
        /// </summary>
        public enum ErrorStatus
        {
            Success,
            Error,
            CustomErr,
        }

        /// <summary>
        /// Login Result
        /// </summary>
        public enum LoginResult
        {
            Success = 0,
            Failed = 1,
        }

        public enum Reminder
        {
            NotReminded,
            HasReminded
        }

        public enum NotifStatus
        {
            NotRead,
            HasRead,
            All
        }
    }
}