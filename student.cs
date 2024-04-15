using System.Reflection.Metadata.Ecma335;
using System.Runtime.Serialization;

class Student  // klassen
{
    public string name;
    public int teknikkunskap;
    public int fotokunskap;
    public int elkunskap;


    static string GetGrade(int value)  // när denna anropas får man ett betyg beroende på hur duktig eleven är
    {
        if (value == 0 || value < 0)
        {
            return "F";
        }
        else if (value == 1)
        {
            return "E";
        }
        else if (value == 2)
        {
            return "C";
        }
        else if (value == 3)
        {
            return "A";
        }
        else
        {
            return "A";
        }
        // int gradete;
        // gradete = teknikkunskap;
        // return gradete;

    }

    public string GetTeknikkunskapGrade()
    {
        return GetGrade(teknikkunskap);
    }

        public string GetFotokunskapgrade()
    {
        return GetGrade(fotokunskap);
    }
        public string GetElkunskapGrade()
    {
        return GetGrade(elkunskap);
    }
}

