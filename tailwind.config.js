/** @type {import('tailwindcss').Config} */
module.exports = {
  content: ["./**/*.{razor,html,}"],
  theme: {
    extend: {
      fontFamily: {
        'inter': ['Inter', 'sans-serif'],
      }
    },
  },
  plugins: [],
}

