#include "pch.h"
#include <string>
#include <functional> 
#include "FormatDuration.h"

std::string numberToText(int n, const std::string& unit)
{
    if (n == 0)
        return "";

    if (n == 1)
        return "1 " + unit + ", ";

    return std::to_string(n) + " " + unit + "s, ";
}

void rtrim(std::string& s) {
    s.erase(std::remove(s.end() - 1, s.end(), ' '), s.end());
    s.erase(std::remove(s.end() - 1, s.end(), ','), s.end());
}

std::string FormatDuration::format_duration(int seconds)
{
    constexpr int secondsInYear = 365 * 24 * 3600;
    constexpr int secondsInDay = 24 * 3600;
    constexpr int secondsInHour = 3600;
    constexpr int secondsInMinute = 60;

    if (seconds == 0)
        return "now";

    auto remainingInYear = seconds % secondsInYear;
    auto remainingInDay = remainingInYear % secondsInDay;
    auto remaingInHour = remainingInDay % secondsInHour;
    auto remaingInMinute = remaingInHour % secondsInMinute;

    auto result = numberToText(seconds / secondsInYear, "year") +
        numberToText(remainingInYear / secondsInDay, "day") +
        numberToText(remainingInDay / secondsInHour, "hour") +
        numberToText(remaingInHour / secondsInMinute, "minute") +
        numberToText(remaingInMinute, "second");

    rtrim(result);
    size_t lastCommaPos = result.find_last_of(",");
    if (lastCommaPos != std::string::npos)
    {
        result = result.replace(lastCommaPos, 1, " and");
    }
    return result;
}
