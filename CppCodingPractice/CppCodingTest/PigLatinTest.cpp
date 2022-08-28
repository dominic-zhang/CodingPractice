#include "pch.h"
#include <string>
#include "PigLatin.h"

TEST(TestPigLatin, TestPigIt) {
    PigLatin pigLatin;
    EXPECT_EQ(pigLatin.pig_it("This is my string"), "hisTay siay ymay tringsay");
    EXPECT_EQ(pigLatin.pig_it("Pig latin is cool"), "igPay atinlay siay oolcay");
    EXPECT_EQ(pigLatin.pig_it("Acta est fabula"), "ctaAay steay abulafay");
    EXPECT_EQ(pigLatin.pig_it("Hello world !"), "elloHay orldway !");
}