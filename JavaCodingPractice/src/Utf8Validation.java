public class Utf8Validation {
    public static boolean validUtf8(int[] data) {
        for (int i = 0; i < data.length; i++) {
            int utf8Length = getUtf8Length(data[i]);
            if (utf8Length < 0 || utf8Length > 4 || i + utf8Length > data.length) {
                return false;
            }

            for (int j = 1; j < utf8Length; j++) {
                if (getUtf8Length(data[i + j]) != -1) {
                    return false;
                }
            }
            i = i + utf8Length - 1;
        }
        return true;
    }

    private static int getUtf8Length(int n) {
        int utf8Length = 0;
        int mask = 0x80;
        while (mask > 0 && (n & mask) == mask) {
            utf8Length++;
            mask /= 2;
        }

        if (utf8Length == 0) {
            return 1;
        }

        if (utf8Length == 1) {
            return -1;
        }

        return utf8Length;
    }
}
