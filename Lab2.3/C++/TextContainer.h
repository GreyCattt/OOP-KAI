#pragma once
#include "String.h"
#include "IDuplicateHandler.h"
#include <vector>
#include <algorithm>
#include <map>

class TextContainer : public IDuplicateHandler {
private:
    std::vector<String> strings;

public:
    // Додавання рядка
    void addString(const String& str) {
        strings.push_back(str);
    }

    // Видалення рядка
    void removeString(const String& str) {
        strings.erase(std::remove(strings.begin(), strings.end(), str), strings.end());
    }

    // Очищення тексту
    void clear() {
        strings.clear();
    }

    // Повернення частоти появи символу
    double getSymbolFrequency(char symbol) const {
        size_t totalSymbols = 0;
        size_t symbolCount = 0;

        for (const auto& str : strings) {
            totalSymbols += str.getValue().length();
            symbolCount += std::count(str.getValue().begin(), str.getValue().end(), symbol);
        }

        return totalSymbols > 0 ? static_cast<double>(symbolCount) / totalSymbols : 0.0;
    }

    // Заміна підрядка
    void replaceSubstring(const std::string& oldSub, const std::string& newSub) {
        for (auto& str : strings) {
            str.replaceSubstring(oldSub, newSub);
        }
    }

    // Реалізація методу для видалення дублюючих рядків
    void removeDuplicates() override {
        std::sort(strings.begin(), strings.end(), [](const String& a, const String& b) {
            return a.getValue() < b.getValue();
        });
        strings.erase(std::unique(strings.begin(), strings.end()), strings.end());
    }

    // Отримання тексту
    std::vector<std::string> getText() const {
        std::vector<std::string> result;
        for (const auto& str : strings) {
            result.push_back(str.getValue());
        }
        return result;
    }
};