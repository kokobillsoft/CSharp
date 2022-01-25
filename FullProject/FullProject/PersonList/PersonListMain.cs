using System;
using System.Collections.Generic;

namespace FullProject
{
    class PersonList
    {
        public static void PersonListMain()
        {
            var newList = CreateList.CreatePersonesList();
            Output.ConsoleWriteList.ConsoleWriteListOfPersones(newList);
        }
    }
}
