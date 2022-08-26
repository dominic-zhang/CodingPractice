#include "pch.h"
#include "MoveZerosToEnd.h"

TEST(TestMoveZeros, TestWithZeros) {
  MoveZerosToEnd moveZero;
  auto result = moveZero.MoveZeros(std::vector<int>{1, 2, 0, 1, 0, 1, 0, 3, 0, 1});
  auto expect = std::vector<int>{ 1, 2, 1, 1, 3, 1, 0, 0, 0, 0 };
  EXPECT_EQ(result, expect);
}

TEST(TestMoveZeros, TestAllZeros) {
    MoveZerosToEnd moveZero;
    auto result = moveZero.MoveZeros(std::vector<int>{0, 0, 0, 0, 0, 0});
    auto expect = std::vector<int>{ 0, 0, 0, 0, 0, 0 };
    EXPECT_EQ(result, expect);
}
TEST(TestMoveZeros, TestNonZeros) {
    MoveZerosToEnd moveZero;
    auto result = moveZero.MoveZeros(std::vector<int>{1, 2, 5, 1, 5, 1, 5, 3, 2, 1});
    auto expect = std::vector<int>{ 1, 2, 5, 1, 5, 1, 5, 3, 2, 1 };
    EXPECT_EQ(result, expect);
}