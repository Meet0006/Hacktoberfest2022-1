void main() {
  final i = 2;
  if (i.isBetween(1, 10)) {
    print('Between');
  } else {
    print('Not between');
  }
}

extension Range on num {
  bool isBetween(num from, num to) {
    return from < this && this < to;
  }
}
