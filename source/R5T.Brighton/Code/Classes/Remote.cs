using System;

using R5T.Delos;


namespace R5T.Brighton
{
    public sealed class Remote : MachineLocation
    {
        public const string Name = "Remote";


        public Remote()
            : base(Remote.Name)
        {
        }
    }
}
