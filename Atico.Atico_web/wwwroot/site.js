// استهداف العناصر

const Up_sections = document.querySelectorAll('.sticky_col');

// دالة التمرير
window.addEventListener('scroll', () => {
    // الحصول على موضع التمرير
    const scrollY = window.scrollY;
    Up_sections.forEach(Up_section =>{
        const section_bound = Up_section.getBoundingClientRect();
        const bottom_Point= section_bound.bottom;
        if (scrollY >  0 & scrollY < bottom_Point ) {
            Up_section.classList.remove('Fixed')

        }
        else{
            Up_section.classList.remove('Fixed')
        }
    });
});
