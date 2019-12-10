using System;

using R5T.Delos;


namespace R5T.Brighton
{
    public sealed class Local : MachineLocation
    {
        public const string Name = "Local";


        public Local()
            : base(Local.Name)
        {
        }
    }
}
