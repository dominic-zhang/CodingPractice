#include "pch.h"
#include <string>
#include<ctype.h>
#include "PigLatin.h"

std::string rotate(std::string str)
{
    if (str.size() > 1)
    {
        return str.substr(1) + str[0] + "ay";
    }
    else if (isalpha(str[0]))
    {
        return str + "ay";
    }

    return str;
}

std::string PigLatin::pig_it(std::string str)
{
    auto found = str.find_first_of(" ");
    auto result = str;
    if (found == std::string::npos)
    {
        result = rotate(str);
    }
    else
    {
        auto strToRotate = str.substr(0, found);
        result = rotate(strToRotate) + " " + pig_it(str.substr(found + 1));
    }

    return result;
}