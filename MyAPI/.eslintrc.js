module.exports = {
    env: {
        es2021: true,
        node: true,
        jest: true,
    },
    extends: 'airbnb-base',
    overrides: [{
        env: {
            node: true,
        },
        files: [
            '.eslintrc.{js,cjs}',
        ],
        parserOptions: {
            sourceType: 'script',
        },
    }, ],
    parserOptions: {
        ecmaVersion: 'latest',
    },
    rules: { 'arrow-body-style': 'off', },
};