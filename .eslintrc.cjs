module.exports = {
  env: {
    browser: true,
    es2021: true,
    node: true,
  },
  extends: [
    // nuxt3
    "plugin:nuxt/recommended",
    "plugin:@typescript-eslint/recommended",
    "plugin:vue/vue3-recommended",
    "plugin:prettier/recommended",
    "plugin:tailwindcss/recommended",
  ],
  overrides: [
    {
      env: {
        node: true,
      },
      files: [".eslintrc.{js,cjs}"],
      parserOptions: {
        sourceType: "script",
      },
    },
    {
      files: [
        "**/components/**/*.{js,ts,vue}",
        "**/pages/**/*.{js,ts,vue}",
        "**/layouts/**/*.{js,ts,vue}",
        "**/app.{js,ts,vue}",
        "**/error.{js,ts,vue}",
      ],
      rules: {
        "vue/multi-word-component-names": "off",
        "vue/html-self-closing": "off",
      },
    },
    {
      files: ["**/presets/**/*.{js,ts,vue}"],
      rules: {
        "@typescript-eslint/no-unused-vars": "off",
      },
    },
  ],
  parserOptions: {
    ecmaVersion: "latest",
    parser: "@typescript-eslint/parser",
    sourceType: "module",
  },
  plugins: ["@typescript-eslint", "vue"],
  rules: {},
};
