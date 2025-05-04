#include <iostream>
#include "StringBase.h"
#include "Letters.h"
#include "Digits.h"

int main() {
    // Створення об'єктів класів
    Letters letters("Hello");
    Digits digits("123");

    // Використання поліморфізму
    StringBase* basePtr = &letters;
    std::cout << "Original (Letters): " << basePtr->getValue() << std::endl;
    std::cout << "Processed (Letters): " << basePtr->process() << std::endl;
    std::cout << "Length (Letters): " << basePtr->getLength() << std::endl;

    basePtr = &digits;
    std::cout << "\nOriginal (Digits): " << basePtr->getValue() << std::endl;
    std::cout << "Processed (Digits): " << basePtr->process() << std::endl;
    std::cout << "Length (Digits): " << basePtr->getLength() << std::endl;

    return 0;
}