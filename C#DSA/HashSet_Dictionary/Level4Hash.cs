using System;
using System.Collections.Generic;

namespace pro
{
    class Developer
    {
        public string Name { get; set; }

        // Override Equals
        public override bool Equals(object obj)
        {
            if (obj is Developer other)
            {
                return string.Equals(this.Name, other.Name, StringComparison.OrdinalIgnoreCase);
            }
            return false;
        }

        // Override GetHashCode
        public override int GetHashCode()
        {
            return Name?.ToLower().GetHashCode() ?? 0;
        }
    }

    class Execution
    {
        static void Main()
        {
            Developer dev = new Developer { Name = "Banhi" };

            var team = new HashSet<Developer> { dev };

            bool found = team.Contains(new Developer { Name = "Banhi" });

            Console.WriteLine(found); // ✅ True now
        }
    }
}
