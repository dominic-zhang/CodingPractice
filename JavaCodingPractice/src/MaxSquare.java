public class MaxSquare {
    public static int maximalSquare(char[][] matrix) {
        int maxLength = 0;

        for (int i = 0; i < matrix.length; i++) {
            if (maxLength > matrix.length - i) {
                break;
            }
            for (int j = 0; j < matrix[0].length; j++) {
                if (maxLength > matrix[0].length - i) {
                    break;
                }

                int length = getMaxSquareLength(matrix, i, j);
                if (length > maxLength) {
                    maxLength = length;
                }
            }
        }

        return maxLength * maxLength;
    }

    private static int getMaxSquareLength(char[][] matrix, int i, int j) {
        if (matrix[i][j] == '0') {
            return 0;
        }

        int maxLength = 1;
        boolean isSquare = true;
        while (isSquare) {
            if (i + maxLength < matrix.length && j + maxLength < matrix[0].length) {
                for (int k = 0; k <= maxLength; k++) {
                    if (matrix[i + k][j + maxLength] == '0' || matrix[i + maxLength][j + k] == '0') {
                        isSquare = false;
                        break;
                    }
                }
                if (isSquare)
                    maxLength++;
            } else {
                isSquare = false;
            }
        }

        return maxLength;
    }
}
