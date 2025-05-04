#pragma once
#include <string>
#include <vector>

class IDuplicateHandler {
public:
    virtual ~IDuplicateHandler() = default;

    // Метод для пошуку та видалення дублюючих рядків
    virtual void removeDuplicates() = 0;
};