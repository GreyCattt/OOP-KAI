#pragma once
#include <string>

class String {
private:
    std::string value;

public:
    // Конструктор
    String(const std::string& str) : value(str) {}

    // Геттер для значення рядка
    std::string getValue() const {
        return value;
    }

    // Метод для заміни підрядка
    void replaceSubstring(const std::string& oldSub, const std::string& newSub) {
        size_t pos = 0;
        while ((pos = value.find(oldSub, pos)) != std::string::npos) {
            value.replace(pos, oldSub.length(), newSub);
            pos += newSub.length();
        }
    }

    // Оператор порівняння
    bool operator==(const String& other) const {
        return value == other.value;
    }
};