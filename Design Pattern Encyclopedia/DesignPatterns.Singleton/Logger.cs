// -----------------------------------------------------------------------
//   <copyright file=Logger.cs>
//      Copyright © 2022. All Rights Reserved.
//   </copyright>
// -----------------------------------------------------------------------
//  <Author>Vaibhav Lawand</Author>

namespace DesignPatterns.Singleton
{
    public sealed class Logger
    {
        #region Private Fields

        private static readonly Lazy<Logger> instance = new Lazy<Logger>(() => new Logger());

        #endregion Private Fields

        #region Private Constructors

        private Logger()
        {
        }

        #endregion Private Constructors

        #region Public Properties

        public static Logger Instance
        {
            get
            {
                return instance.Value;
            }
        }

        #endregion Public Properties
    }
}