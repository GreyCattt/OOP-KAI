#pragma once
#include "StringBase.h"
#include <algorithm>

class Letters : public StringBase {
public:
    // Конструктор з параметром
    Letters(const std::string& str) : StringBase(str) {}

    // Перевизначення функції для обробки рядка (перевертання)
    std::string process() const override {
        std::string reversed = value;
        std::reverse(reversed.begin(), reversed.end());
        return reversed;
    }
};