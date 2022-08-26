#include "pch.h"

#include <vector>
#include <algorithm>
#include "MoveZerosToEnd.h"

std::vector<int> MoveZerosToEnd::MoveZeros(const std::vector<int>& input)
{
    std::vector<int> result = input;
    std::stable_partition(result.begin(), result.end(), [](int n) {return n != 0; });
    return result;
}

