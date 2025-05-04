#pragma once
#include <string>

class StringBase {
protected:
    std::string value;

public:
    // Конструктор з параметром
    StringBase(const std::string& str) : value(str) {}

    // Віртуальний деструктор
    virtual ~StringBase() {}

    // Віртуальна функція для обчислення довжини рядка
    virtual size_t getLength() const {
        return value.length();
    }

    // Віртуальна функція для обробки рядка
    virtual std::string process() const = 0;

    // Геттер для значення рядка
    std::string getValue() const {
        return value;
    }
};