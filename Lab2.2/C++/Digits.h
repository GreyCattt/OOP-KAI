#pragma once
#include "StringBase.h"

class Digits : public StringBase {
public:
    // Конструктор з параметром
    Digits(const std::string& str) : StringBase(str) {}

    // Перевизначення функції для обробки рядка (подвоєння)
    std::string process() const override {
        return value + value;
    }
};