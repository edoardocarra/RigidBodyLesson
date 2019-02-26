from pyPdf import PdfFileWriter, PdfFileReader

with open("Tonge_Richard_PhysicsForGame.pdf", "rb") as in_f:
    input1 = PdfFileReader(in_f)
    output = PdfFileWriter()

    numPages = input1.getNumPages()
    print "document has %s pages." % numPages

    for i in range(numPages):
        if i==16 or i==35:
            continue;
        page = input1.getPage(i)
        print page.mediaBox.getUpperRight_x(), page.mediaBox.getUpperRight_y()
        # page.trimBox.lowerLeft = (25, 25)
        # page.trimBox.upperRight = (225, 225)
        page.cropBox.lowerLeft = (30, 666)
        page.cropBox.upperRight = (510, 398)
        output.addPage(page)

    with open("out.pdf", "wb") as out_f:
        output.write(out_f)