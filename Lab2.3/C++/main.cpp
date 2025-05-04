#include <iostream>
#include "TextContainer.h"

int main() {
    TextContainer text;

    // Додавання рядків
    text.addString(String("Hello"));
    text.addString(String("World"));
    text.addString(String("Hello")); // Дублюючий рядок
    text.addString(String("C++ Programming"));

    // Отримання тексту
    auto lines = text.getText();
    std::cout << "Original text:" << std::endl;
    for (const auto& line : lines) {
        std::cout << line << std::endl;
    }

    return 0;
}