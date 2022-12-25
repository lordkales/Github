[16,21,11,8,12,22] -> Merge Sort

Yukarıdaki dizinin sort türüne göre aşamalarını yazınız.
Big-O gösterimini yazınız.

[16,21,11] - [8,12,22] olarak diziyi ikiye ayırıyorum
[16,21] - [11] - [8,12] - [22] yukarıda ikiye ayırdığım diziyi tekrar ikiye ayırıyorum.
[16] - [21] - [11] - [8] - [12] - [22] diziyi tek parçalara ayırdım. Şimdi bunları sıralı olarak ikili şekilde birleştiriyorum
[16,21] - [8,11] - [12,22] olarak sıralı şekilde birleştirdim. Daha sonra bunları da sıralı şekilde birleştiriyorum.
[8,11,16,21] - [12,22] olarak ilk iki dizemi birleştirdim. Şimdi son adımda kalan üçüncü dizeyi birleştiriyorum
[8,11,12,16,21,22] olarak dizemi sıralıyorum.

Big O(nlogn)