/** @type {import('tailwindcss').Config} */
const defaultTheme = require('tailwindcss/defaultTheme')
module.exports = {
    content: [
        './Views/**/*.cshtml',
        './Pages/**/*.cshtml',
        './Areas/**/*.cshtml'
    ],
    theme: {
        fontFamily: {
            'sans': ['Merriweather', ...defaultTheme.fontFamily.sans],
        },
        extend: {},
    },
    plugins: [
        require('@tailwindcss/forms'),
        function ({ addVariant }) {
            addVariant(
                'supports-backdrop-blur',
                '@supports (backdrop-filter: blur(0)) or (-webkit-backdrop-filter: blur(0))'
            )
            addVariant('supports-scrollbars', '@supports selector(::-webkit-scrollbar)')
            addVariant('children', '& > *')
            addVariant('scrollbar', '&::-webkit-scrollbar')
            addVariant('scrollbar-track', '&::-webkit-scrollbar-track')
            addVariant('scrollbar-thumb', '&::-webkit-scrollbar-thumb')
        },
    ],
}