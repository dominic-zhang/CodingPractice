#include "pch.h"
#include <string>
#include <vector>
#include "RangeExtraction.h"

std::string RangeExtraction::range_extraction(std::vector<int> args)
{
    std::string result;
    std::vector<int> continous = {};
    auto appendToResult = [&]() {
        if (continous.size() < 3)
        {
            for (auto k : continous)
            {
                result += std::to_string(k) + ",";
            }
        }
        else
        {
            result += std::to_string(continous.front()) + "-" + std::to_string(continous.back()) + ",";
        }
    };

    for (auto n : args)
    {
        if (continous.size() == 0)
        {
            continous.push_back(n);
            continue;
        }

        if (n != continous.back() + 1)
        {
            appendToResult();
            continous.clear();
        }
        continous.push_back(n);
    }

    if (continous.size() > 0)
    {
        appendToResult();
    }

    result.erase(result.find_last_of(","));
    return result;
}