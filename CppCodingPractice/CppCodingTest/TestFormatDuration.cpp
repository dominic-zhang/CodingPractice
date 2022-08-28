#include "pch.h"
#include <string>
#include "FormatDuration.h"

TEST(TestFormatDuration, TestDurations) {
    FormatDuration formatDuration;
    EXPECT_EQ(formatDuration.format_duration(0), "now");
    EXPECT_EQ(formatDuration.format_duration(1), "1 second");
    EXPECT_EQ(formatDuration.format_duration(62), "1 minute and 2 seconds");
    EXPECT_EQ(formatDuration.format_duration(120), "2 minutes");
    EXPECT_EQ(formatDuration.format_duration(3662), "1 hour, 1 minute and 2 seconds");
}

TEST(TestFormatDuration, TestFurther) {
    FormatDuration formatDuration;
    EXPECT_EQ(formatDuration.format_duration(132030240), "4 years, 68 days, 3 hours and 4 minutes");
}