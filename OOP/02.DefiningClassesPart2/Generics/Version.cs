/* 11
 * Create a [Version] attribute that can be applied to structures, classes, interfaces, 
 * enumerations and methods and holds a version in the format major.minor (e.g. 2.11). 
 * Apply the version attribute to a sample class and display its version at runtime.*/

//Test is in Program.cs
namespace Generics
{
    using System;

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface
        | AttributeTargets.Enum | AttributeTargets.Method, AllowMultiple = false)]
    public class VersionAttribute : Attribute
    {
        public int Major { get; set; }
        public int Minor { get; set; }

        public VersionAttribute(int major, int minor)
        {
            this.Major = major;
            this.Minor = minor;
        }
    }
}
