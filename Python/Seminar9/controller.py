import text
import view
import model


def start():
    while True:
        choice = view.main_menu()
        match choice:
            case 1:
                model.open_pb()
                view.print_massage(text.load_successful)
            case 2:
                model.save_pb()
                view.print_massage(text.save_successful)
            case 3:
                pb = model.get_pb()
                view.print_contact(pb, text.load_error)
            case 4:
                contact = view.input_contact(
                    text.new_contact, text.cancel_input)
                name = model.add_contact(contact)
            case 5:
                pass
            case 6:
                pass
            case 7:
                pb = model.get_pb()
                index = view.input_index(text.index_del_contact, pb, text.load_error)
                name = model.del_contact(index)
            case 8:
                break
